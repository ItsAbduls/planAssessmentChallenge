using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aptitude_test
{

    abstract class AbstractFactory
    {
        public abstract AbstractProduct ShowSkill();
    }

    class Dancing : AbstractFactory
    {
        public override AbstractProduct ShowSkill()
        {
            return new Dance();
        }
    }

    class Cooking : AbstractFactory
    {
        public override AbstractProduct ShowSkill()
        {
            return new Cook();
        }
    }

    abstract class AbstractProduct
    {
        public abstract string Interact();
    }

    class Dance : AbstractProduct
    {
        public override string Interact()
        {
            return "dancing";
        }
    }

    class Cook : AbstractProduct
    {
        public override string Interact()
        {
            return "cooking";
        }
    }

    class Humanoid
    {
        private AbstractProduct _abstractProduct;
        // Constructor
        public Humanoid(AbstractFactory factory = null)
        {
            _abstractProduct = factory?.ShowSkill();
        }
        public string ShowSkill()
        {
            if (_abstractProduct != null)
            {
                return _abstractProduct.Interact();
            }
            return "no skill is defined";
        }
    }
}
