// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Schema;
using static TaskCenterService.QueryTasksSoapClient;

namespace Microsoft.BotBuilderSamples.Dialogs
{
    public class CancelAndHelpDialog : ComponentDialog
    {
        public CancelAndHelpDialog(string id)
            : base(id)
        {
        }

        protected override async Task<DialogTurnResult> OnBeginDialogAsync(DialogContext innerDc, object options, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await InterruptAsync(innerDc, cancellationToken);
            if (result != null)
            {
                return result;
            }

            return await base.OnBeginDialogAsync(innerDc, options, cancellationToken);
        }

        protected override async Task<DialogTurnResult> OnContinueDialogAsync(DialogContext innerDc, CancellationToken cancellationToken)
        {
            var result = await InterruptAsync(innerDc, cancellationToken);
            if (result != null)
            {
                return result;
            }

            return await base.OnContinueDialogAsync(innerDc, cancellationToken);
        }

        private async Task<DialogTurnResult> InterruptAsync(DialogContext innerDc, CancellationToken cancellationToken)
        {
            if (innerDc.Context.Activity.Type == ActivityTypes.Message)
            {
                var text = innerDc.Context.Activity.Text.ToLowerInvariant();

                switch (text)
                {
                    case "help":
                    case "?":
                        await innerDc.Context.SendActivityAsync($"Show Help 11111...", cancellationToken: cancellationToken);
                        return new DialogTurnResult(DialogTurnStatus.Waiting);

                    case "cancel":
                    case "quit":
                        await innerDc.Context.SendActivityAsync($"Cancelling", cancellationToken: cancellationToken);
                        return await innerDc.CancelAllDialogsAsync();
                    case "待办":
                    case "查询待办":
                        TaskCenterService.QueryTasksSoapClient entity = new TaskCenterService.QueryTasksSoapClient(EndpointConfiguration.QueryTasksSoap);
                        var list = entity.QueryAsync("liuxiaoping3", 1, 5, null).Result.Items;
      
                        foreach (TaskCenterService.TW_TaskEntity item in list)
                        {
                           var str = item.Title + "  " + item.ActionUrl;
                            await innerDc.Context.SendActivityAsync(str, cancellationToken: cancellationToken);
                        }

                        return new DialogTurnResult(DialogTurnStatus.Waiting);
                    case "日程":
                    case "查询日程":
                        await innerDc.Context.SendActivityAsync($"测试日程 https://www.baidu.com:", cancellationToken: cancellationToken);
                        return new DialogTurnResult(DialogTurnStatus.Waiting);
                }
            }

            return null;
        }
    }
}
