﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Bot.Connector
{
    public partial class ThumbnailCard
    {
        public const string ContentType = "application/vnd.microsoft.card.thumbnail";
    }

    public partial class HeroCard
    {
        public const string ContentType = "application/vnd.microsoft.card.hero";
    }

    public partial class ReceiptCard
    {
        public const string ContentType = "application/vnd.microsoft.card.receipt";
    }

    public partial class SigninCard
    {
        public const string ContentType = "application/vnd.microsoft.card.signin";
    }
}
