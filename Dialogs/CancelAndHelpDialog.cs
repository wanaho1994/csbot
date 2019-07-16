// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Schema;
using static TaskCenterService.ServiceSoapClient;

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
                        TaskCenterService.ServiceSoapClient entity = new TaskCenterService.ServiceSoapClient(EndpointConfiguration.ServiceSoap);

                        var list = entity.QueryDoneTasksAsync("liuxiaoping3","Password01!", 1, 5).Result.Items;
      
                        foreach (TaskCenterService.MuMobileTaskEntity item in list)
                        {
                           var str = item.Title + "  " + item.ActionUrl;
                            await innerDc.Context.SendActivityAsync(str, cancellationToken: cancellationToken);
                        }

                        return new DialogTurnResult(DialogTurnStatus.Waiting);
                    case "日程":
                    case "查询日程":
                        await innerDc.Context.SendActivityAsync($"测试日程1  http://wuye.ceair.com:8087/PortalEx/Refresh?IframeId=2b08c379-5665-4573-b390-e256cbca4ed2&WebPartCode=DHWY_Calendar&IsWrapindiv=false&nocache=0.1731581676535483:", cancellationToken: cancellationToken);
                        return new DialogTurnResult(DialogTurnStatus.Waiting);
                }
            }

            return null;
        }
    }
}
