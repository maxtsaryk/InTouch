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
            builder.Property(e => e.Content).IsRequired();
            builder.Property(e => e.CreateTime).IsRequired();
            builder.Property(e => e.UpdateTime).IsRequired();
            builder.Property(e => e.Status).HasDefaultValue(MessageStatus.NotSent);
        }
    }
}
