using System;
using System.Collections.Generic;
using System.Text;

namespace TesteAbstractFactory.Interface
{
    public interface IBaseBusiness<IModel>
    {
        public void Salvar(IModel modelo);
    }
}
