using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Factory;
using Client.Model;
using Client.View;

namespace Client.Controller
{
    public class OpenQuestionController : AbstractController<Model.OpenQuestion>
    {
        public override IView GetView()
        {
            throw new NotImplementedException();
        }

        public override void SetBaseFactory(IFactory<OpenQuestion> baseFactory)
        {
            throw new NotImplementedException();
        }

        public override void SetView(IView view)
        {
            throw new NotImplementedException();
        }
    }
}
