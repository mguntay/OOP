using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance_
{
   public class SmartPhone:MobilePhone
    {
        public bool FrontCam { get; set; }
        public SmartPhone()
        {
            base._phoneType = "Smart Phone";
        }
        public SmartPhone(bool frontCam, bool hasCamera, bool isTouched, string brand, string connectionType) : base(hasCamera, isTouched, brand, connectionType)
        {
            this.FrontCam = frontCam;
            this._phoneType = "Smart Phone";
        }
        public string VideoCall()
        {
            return "Calling...";
        }
        public override string Sound() ////virtual olarak ayarlandığı için override olarak ayarlayıp değiştirebiliyoruz.
        {
            return "smart sound";
        }
    }
}
