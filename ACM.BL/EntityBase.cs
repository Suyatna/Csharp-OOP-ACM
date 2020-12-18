using System.ComponentModel.Design;

namespace ACM.BL
{
    public enum EntityStateOperation
    {
        Active,
        Deleted
    }
    
    public abstract class EntityBase
    {
        public bool isNew { get; private set; }
        public bool hasChange { get; set; }

        public bool isValid => Validate();

        public abstract bool Validate();

        public EntityStateOperation entityState { get; set; }
    }
}