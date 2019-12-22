using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance_
{
   public class MobilePhone:BasePhone
    {
        public bool HasCamera
        {
            get;
            set;
        }
        public bool IsTouched
        {
            get;
            set;
        }
        public MobilePhone()
        {
            base._phoneType = "Mobil Phone";
        }
        public MobilePhone(bool hasCamera,bool isTouched, string brand, string connectionType) : base(brand,connectionType)
        {
            this.HasCamera = hasCamera;
            this.IsTouched = isTouched;
        }
        public string TakePhoto()
        {
            if(this.HasCamera)
            {
                return "You can take photo.";
            }
            return "You can not take photo.";

        }
        public override string Sound()
        {
            return "mobil sound";
        }

    }
}
