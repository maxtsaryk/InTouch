using InTouch.Data.Chat.Entities;
using InTouch.Data.Chat.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InTouch.Data.Chat.Configurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<MessageEntity>
    {
        public void Configure(EntityTypeBuilder<MessageEntity> builder)
        {
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.CreateTime).IsRequired();
            builder.Property(x => x.UpdateTime).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(MessageStatus.NotSent);
        }
    }
}
