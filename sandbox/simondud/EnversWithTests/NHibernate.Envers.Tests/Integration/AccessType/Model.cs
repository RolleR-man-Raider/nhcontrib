namespace NHibernate.Envers.Tests.Integration.AccessType
{
    public class FieldAccessEntity
    {
        private int id;
        [Audited]
        private string data;

        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual string Data
        {
            get { return data; }
            set { data = value; }
        }

        public override bool Equals(object obj)
        {
            var bte = obj as FieldAccessEntity;
            if (bte == null)
                return false;
            return (bte.Id == Id && string.Equals(bte.Data, Data));
        }

        public override int GetHashCode()
        {
            return Id ^ Data.GetHashCode();
        }
    }

    public class PropertyAccessEntity
    {
        public virtual int Id { get; set; }
        [Audited]
        public virtual string Data { get; set; }
    }
}