using System;

namespace Version_2_C
{
    [Serializable()]
    public class clsPhotograph : clsWork
    {
        private float _Width;
        private float _Height;
        private string _Type;

        public delegate void LoadPhotographFormDelegete(clsPhotograph prPhotograph);
        public static LoadPhotographFormDelegete LoadPhotographForm;

        //[NonSerialized()]
        //private frmPhotograph _PhotoDialog;

        public override void EditDetails()
        {
            LoadPhotographForm(this);
            //frmPhotograph.Instance.SetDetails(this);
            //if (_PhotoDialog == null)
            //    _PhotoDialog = new frmPhotograph();
            //_PhotoDialog.SetDetails(this);
        }

        public Single Width
        {
            get { return _Width; }
            set { _Width = value; }
        }

        public Single Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
    }
}
