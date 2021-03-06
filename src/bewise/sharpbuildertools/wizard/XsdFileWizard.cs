using System;
using System.Diagnostics;
using System.Windows.Forms;
using Borland.Studio.ToolsAPI;
using BeWise.Common.Utils;
using BeWise.SharpBuilderTools.Gui;
using BeWise.SharpBuilderTools.Wizard.Creator;

namespace BeWise.SharpBuilderTools.Wizard {

    public class XsdFileWizard : BaseWizard, IOTAWizard, IOTARepositoryWizard, IOTAFormWizard {


        // *************************************************************************
        //                              Constructor
        // *************************************************************************
        []
		public XsdFileWizard(IOTAGalleryCategory aCat) : base(aCat) {
        }

        /**************************************************************/
        /*                       Public
        /**************************************************************/

        // IOTAWizard
        public string IDString {
            get {
                return "SharpBuilderTools.XsdFileWizard";
            }
        }

        public void Execute() {
            FrmNewFileName _FrmNewFileName = new FrmNewFileName();

            if (_FrmNewFileName.ShowDialog() == DialogResult.OK) {
                IOTAModuleServices _ModuleServices = OTAUtils.GetModuleServices();
                XsdFileCreator _XsdFileCreator = new XsdFileCreator(Utils.AddExtension(_FrmNewFileName.FileName, Consts.XSD_FILE_EXTENSION));
                _ModuleServices.CreateModule(_XsdFileCreator);
            }
        }

        public string Name {
            get {
                return "Xsd File Wizard";
            }
        }

        public string Comment {
            get {
                return "Xsd File Wizard";
            }
        }

        public System.IntPtr Glyph {
            get {
                return System.IntPtr.Zero;
            }
        }

        public string Personality {
            get {
                return OTAIDEPersonalities.sDefaultPersonality;
            }
        }
    }
}
