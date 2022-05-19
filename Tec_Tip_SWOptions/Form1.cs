using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tec_Tip_SWOptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SldWorks swApp;
        private void Form1_Load(object sender, EventArgs e)
        {
            swApp = new SldWorks();
            TextBox_StepFormat.Text = swApp.GetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swStepAP).ToString();
            switch(swApp.GetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swStepExportPreference))
            {
                case (int)swAcisOutputGeometryPreference_e.swAcisOutputAsSolidAndSurface:
                    RadioButton_SolidSurfaceGeometry.Checked = true;
                    RadioButton_Wireframe.Checked = false;
                    CheckBox_ExportSketch.Checked = false;
                    break;
                case (int)swAcisOutputGeometryPreference_e.swAcisOutputAs3DCurves:
                    RadioButton_SolidSurfaceGeometry.Checked = false;
                    RadioButton_Wireframe.Checked = true;
                    CheckBox_ExportSketch.Checked = false;
                    break;
                case (int)swAcisOutputGeometryPreference_e.swAcisOutputAs3DCurves_IncludeSketchEnts:
                    RadioButton_SolidSurfaceGeometry.Checked = false;
                    RadioButton_Wireframe.Checked = true;
                    CheckBox_ExportSketch.Checked = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(RadioButton_SolidSurfaceGeometry.Checked)
            {
                swApp.SetUserPreferenceIntegerValue(
                    (int)swUserPreferenceIntegerValue_e.swStepExportPreference, 
                    (int)swAcisOutputGeometryPreference_e.swAcisOutputAsSolidAndSurface);
            }
            if(RadioButton_Wireframe.Checked)
            {
                if(CheckBox_ExportSketch.Checked)
                {
                    swApp.SetUserPreferenceIntegerValue(
                        (int)swUserPreferenceIntegerValue_e.swStepExportPreference, 
                        (int)swAcisOutputGeometryPreference_e.swAcisOutputAs3DCurves);
                }
                else
                {
                    swApp.SetUserPreferenceIntegerValue(
                        (int)swUserPreferenceIntegerValue_e.swStepExportPreference, 
                        (int)swAcisOutputGeometryPreference_e.swAcisOutputAs3DCurves_IncludeSketchEnts);
                }
            }
            swApp.SetUserPreferenceIntegerValue(
                (int)swUserPreferenceIntegerValue_e.swStepAP,
                Convert.ToInt32(TextBox_StepFormat.Text));
            this.Close();
        }
    }
}
