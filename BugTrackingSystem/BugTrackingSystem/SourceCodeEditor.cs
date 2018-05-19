using ICSharpCode.TextEditor.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem
{
    public partial class SourceCodeEditor : Form
    {

        private string code;
        public SourceCodeEditor(String code)
        {
            InitializeComponent();
            this.code = code;
        }


        private void SourceCodeEditor_Load(object sender, EventArgs e)
        {
            string dir = Application.StartupPath;

            FileSyntaxModeProvider fileSyntaxMode = new FileSyntaxModeProvider(dir);

            HighlightingManager.Manager.AddSyntaxModeFileProvider(fileSyntaxMode);
            textEditorControl1.SetHighlighting("C#");
            textEditorControl1.Text = code;
            String text = textEditorControl1.Text;
            Debug.WriteLine(text);
        }
    }
}
