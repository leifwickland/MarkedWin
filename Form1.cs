using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using mshtml;

namespace MarkedWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists(pathToMmd))
            {
                this.errorMessageLabel.Text = "Couldn't find multimarkdown.exe.  Looked in " + pathToMmd;
                this.Enabled = false;
            }
        }

        private string startupDirectory = Environment.CurrentDirectory;
        private string pathToMmd = Environment.CurrentDirectory + Path.DirectorySeparatorChar + "multimarkdown.exe";

        private void inputPathButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Markdown (*.md,*.markdown)|*.md;*.markdown|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.inputPathTextBox.Text = openFileDialog1.FileName;
                this.outputPathTextBox.Text = Path.GetDirectoryName(openFileDialog1.FileName) + "\\" + Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + ".html";
            }
        }

        private void inputPathTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // TODO this should cancel any previous watch
                updatePreview(this.inputPathTextBox.Text);
                watchForChanges(this.inputPathTextBox.Text);
            }
            catch (Exception ex)
            {
                this.errorMessageLabel.Text = ex.Message;
                return;
            }
        }

        private void watchForChanges(string pathToMarkdown)
        {
            this.fileSystemWatcher1.Path = System.IO.Path.GetDirectoryName(pathToMarkdown);
            this.fileSystemWatcher1.Filter = System.IO.Path.GetFileName(pathToMarkdown);
        }

        private void updatePreview(string pathToMarkdown)
        {
            this.errorMessageLabel.Text = "Beginning to update preview";
            RecordScrollPosition();
            var htmlPath = convertMarkdownToHtml(pathToMarkdown, this.outputPathTextBox.Text, this.cssPathTextBox.Text);
            if (htmlPath != null)
            {
                this.webBrowser1.Navigate(htmlPath);
                this.webBrowser1.Document.Encoding = "utf-8";
                this.errorMessageLabel.Text = "Updated preview at " + DateTime.Now.ToString();
            }
        }

        private void RecordScrollPosition()
        {
            if (this.webBrowser1.Document == null)
            {
                Console.WriteLine("Doc is null");
                oldDocumentView = null;
            }
            else if (this.webBrowser1.Document.GetElementsByTagName("HTML").Count == 0)
            {
                Console.WriteLine("No HTML");
                oldDocumentView = null;
            }
            else
            {
                this.oldDocumentView = this.webBrowser1.Document.GetElementsByTagName("HTML")[0].ScrollRectangle;
                Console.WriteLine("oldDocumentView = " + this.oldDocumentView);
            }
        }

        private Nullable<Rectangle> oldDocumentView;

        private string convertMarkdownToHtml(string pathToMarkdown, string outputPath, string pathToCss)
        {
            if (string.IsNullOrWhiteSpace(pathToMarkdown) || string.IsNullOrWhiteSpace(outputPath))
            {
                return null;
            }
            var info = new ProcessStartInfo(this.pathToMmd);
            var tempPath = outputPath + ".tmp";
            info.Arguments = "-t html -o \"" + tempPath + "\" \"" + pathToMarkdown + "\"";
            Console.WriteLine(info.Arguments);
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.UseShellExecute = false;
            info.RedirectStandardError = true;
            var process = Process.Start(info);
            process.WaitForExit();
            var errors = process.StandardError.ReadToEnd();
            this.errorMessageLabel.Text = errors;
            if (String.IsNullOrWhiteSpace(errors))
            {
                var html = File.ReadAllText(tempPath);
                //html = htmlHeader + html.Substring(html.IndexOf("</head>"));
                if (!String.IsNullOrWhiteSpace(pathToCss))
                {
                    var css = File.ReadAllText(pathToCss);
                    html = html.Replace("</head>", "  <style>\n" + css + "\n</style>\n" + "</head>");
                }
                //html = html.Replace("<body>", "<body>\n  <div id=\"wrapper\">\n");
                //html = html.Replace("</body>", "  </div>\n<body>");
                html = html.Replace("\r\n", "\n"); // Unix me, baby!
                File.WriteAllText(tempPath, html);
                if (File.Exists(tempPath))
                {
                    if (File.Exists(outputPath))
                    {
                        File.Delete(outputPath);
                    }
                    Directory.Move(tempPath, outputPath);
                }
                return outputPath;
            }
            return null;
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            try
            {
                this.updatePreview(this.inputPathTextBox.Text);
            }
            catch (Exception ex)
            {
                this.errorMessageLabel.Text = ex.Message;
                return;
            }
        }

        private void cssPathButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.cssPathTextBox.Text = openFileDialog1.FileName;
            }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (this.oldDocumentView.HasValue)
            {
                this.webBrowser1.Document.Window.ScrollTo(this.oldDocumentView.Value.Left, this.oldDocumentView.Value.Top);
            }
            this.webBrowser1.Document.Encoding = "utf-8";
        }

        private static string htmlHeader
        {
            get
            {
                return @"<!DOCTYPE html>  
<html lang=""en"">
<head>
  <meta charset=""utf-8"">
  <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
  <title>ActionCaptureService_DesignDoc</title>
  <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
".Replace("\r\n", "\n");
            }
        }

        private void outputPathTextBox_TextChanged(object sender, EventArgs e)
        {
            // TODO this should cancel any previous watch
            updatePreview(this.inputPathTextBox.Text);
        }
    }
}