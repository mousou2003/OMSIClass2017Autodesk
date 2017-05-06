//Copyright 2017 Mourad Souag



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Inventor.Application _invApp;
        bool _started = false;
        const string _inventorApp = "Inventor.Application";

        public Form1()
        {
            InitializeComponent();
            try
            {
                _invApp = (Inventor.Application)Marshal.GetActiveObject(_inventorApp);
            }
            catch
            {
                try
                {
                    Type inAppType = Type.GetTypeFromProgID(_inventorApp);

                    _invApp = (Inventor.Application)System.Activator.CreateInstance(inAppType);
                    _invApp.Visible = true;
                    _started = true;
                }
                catch(Exception inAppNotInstalledException)
                {
                    MessageBox.Show(inAppNotInstalledException.ToString());
                    MessageBox.Show("Unable to get or start Inventor");
                }
            }
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            if (_invApp.Documents.Count == 0)
            {
                MessageBox.Show("Need a document open to continue");
                return;
            }
            if(_invApp.ActiveDocument.DocumentType != Inventor.DocumentTypeEnum.kAssemblyDocumentObject)
            {
                MessageBox.Show("Need a assembly document");
                return;
            }
            if (_invApp.ActiveDocument.SelectSet.Count ==0)
            {
                MessageBox.Show("Need to select a part or subassemly");
                return;
            }

            try
            {
                Inventor.ComponentOccurrence compOcc = default(Inventor.ComponentOccurrence);
                object obj = null;
                foreach (object objSelected in _invApp.ActiveDocument.SelectSet)
                {
                    compOcc = (Inventor.ComponentOccurrence)objSelected;
                    System.Diagnostics.Debug.Print(compOcc.Name);
                    compOcc.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Did you select anything?");
            }
        }
    }
}
