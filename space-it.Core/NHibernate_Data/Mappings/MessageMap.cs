using Space_it.Core.Entities;

namespace Space_it.Core.NHibernate_Data.Mappings
{
    public class MessageMap : BaseMap<Message>
    {
        public MessageMap()
        {
            Map(x => x.Text).Not.Nullable();
            References(x => x.Project)
                .Cascade.SaveUpdate();
            References(x => x.User)
                .Cascade.SaveUpdate();
        }
    }
}
