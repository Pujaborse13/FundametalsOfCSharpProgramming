using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples_CSharp
{

    // Liskov Substitution Principle(LSP)
    //A subclass should be able to replace its parent class without breaking the system.

    //Without LSP Rule
    public class Bird
    {
        public void Fly() { /* Common flying behavior */ }
    }

    public class Ostrich : Bird
    {
        public new void Fly() { /* Ostrich-specific behavior (non-flying) */ }
    }

    // -------------------------------------------------------------

    public class Bird1
    {
        public virtual void Fly() { /* Common flying behavior */ }
    }

    public class Sparrow : Bird1
    {
        public override void Fly() { /* Sparrow-specific flying behavior */ }
    }

    public class Ostrich1 : Bird1
    {
        public override void Fly() { /* Ostrich-specific behavior (non-flying) */ }
    }

}
