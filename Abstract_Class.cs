using System;

namespace task_3_3
{
    public abstract class Massive : IBase
    {
        protected bool Choice;
        protected abstract void GetMass();
        protected abstract void GetMass_user();
        public abstract void PrintMass();
        public abstract void Average();
        public Massive(bool choice)
        {
            Choice = choice;
        }
        public void ReCreate()
        {
            if (Choice)
            {
                GetMass_user();
            }
            else
            {
                GetMass();
            }
        }
    }
}