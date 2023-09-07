using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace Bot.Handlers;

public partial class BotUpdateHandler
{
    public async Task MenuSeettignsUz(
        ITelegramBotClient bot,
        CallbackQuery? message,
        CancellationToken cancellation)
    {

        var replyKeyboard = new ReplyKeyboardMarkup(
            new[]
            {
                new []
                {
                    new KeyboardButton("Tilni o'zgartirsh👅"),
                }
            })
        {
            ResizeKeyboard = true
        };

        await bot.SendTextMessageAsync(
            chatId: message.From.Id,
            text: "Kerakli bo'limni tanlang:",
            replyMarkup: replyKeyboard,
            cancellationToken: cancellation
        );
    }
    public async Task MenuSeettignsRu(
        ITelegramBotClient bot,
        CallbackQuery? message,
        CancellationToken cancellation)
    {

        var replyKeyboard = new ReplyKeyboardMarkup(
            new[]
            {
                new []
                {
                    new KeyboardButton("Изменить язык👅"),
                }
            })
        {
            ResizeKeyboard = true
        };

        await bot.SendTextMessageAsync(
            chatId: message.From.Id,
            text: "Выберите нужный раздел",
            replyMarkup: replyKeyboard,
            cancellationToken: cancellation
        );
    }

    public async Task MenuSeettignsEng(
        ITelegramBotClient bot,
        CallbackQuery? message,
        CancellationToken cancellation)
    {

        var replyKeyboard = new ReplyKeyboardMarkup(
            new[]
            {
                new []
                {
                    new KeyboardButton("Change language👅"),
                }
            })
        {
            ResizeKeyboard = true
        };

        await bot.SendTextMessageAsync(
            chatId: message.From.Id,
            text: "Choose needed section:",
            replyMarkup: replyKeyboard,
            cancellationToken: cancellation
        );

    }
}
