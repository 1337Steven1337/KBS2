using System;
using Client.Factory;
using Client.View;
using System.Net;

namespace Client.Controller.Main
{
    public class ShowStartController : AbstractController<Model.Pincode>
    {
        private IView View { get; set; }
        private PincodeFactory PincodeFactory = new PincodeFactory();

        public ShowStartController(IView view)
        {
            this.SetView(view);
        }

        private void UseCode(Model.Pincode pincode, HttpStatusCode code)
        {
            if(pincode != null && code != HttpStatusCode.OK)
            {

            }
            else
            {

            }
        }

        public override IView GetView()
        {
            return this.View;
        }

        public override void SetBaseFactory(IFactory<Model.Pincode> baseFactory)
        {
            PincodeFactory.SetBaseFactory(baseFactory);
        }

        public override void SetView(IView view)
        {
            this.View = view;
        }

        public void CheckCode(string code)
        {
            this.PincodeFactory.FindById(code, this.View.GetHandler(), this.UseCode);
        }
    }
}
