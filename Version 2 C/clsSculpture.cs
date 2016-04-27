using System;

namespace Version_2_C
{
    [Serializable()]
    public class clsSculpture : clsWork
    {
        private float _Weight;
        private string _Material;

        public delegate void LoadSculptureFormDelegate(clsSculpture prSculpture);
        public static LoadSculptureFormDelegate LoadSculptureForm;
        //[NonSerialized()]
        //private static frmSculpture _SculptureDialog;

        public override void EditDetails()
        {
            LoadSculptureForm(this);
            //frmSculpture.Instance.SetDetails(this);
            //if (_SculptureDialog == null)
            //    _SculptureDialog = new frmSculpture();
            //_SculptureDialog.SetDetails(this);
        }

        public Single Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        public string Material
        {
            get { return _Material; }
            set { _Material = value; }
        }
    }
}
