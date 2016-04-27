using System;

namespace Version_2_C
{
    [Serializable()]
    public class clsPainting : clsWork
    {
        private float _Width;
        private float _Height;
        private string _Type;


        //[NonSerialized()]
        //private static frmPainting _PaintDialog;
        public delegate void LoadPaintingFormDelegate(clsPainting prPainting);
        public static LoadPaintingFormDelegate LoadPaintingForm;
        public override void EditDetails()
        {
            LoadPaintingForm(this);
            //frmPainting.Instance.SetDetails(this);
            //if (_PaintDialog == null)
            //    _PaintDialog = new frmPainting();
            //_PaintDialog.SetDetails(this);
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
