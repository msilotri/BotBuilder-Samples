﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License

using System;
using System.Collections.Generic;
using Microsoft.Bot.Builder.AI.Luis;

namespace LuisBot
{
    /// <summary>
    /// Represents the bot's references to external services.
    ///
    /// For example, LUIS services are kept here (singletons).  These external services are configured
    /// using the <see cref="BotConfiguration"/> class (based on the contents of your ".bot" file).
    /// </summary>
    /// <seealso cref="https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.1"/>
    /// <seealso cref="https://www.luis.ai/home"/>
    [Serializable]
    public class BotServices
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BotServices"/> class.
        /// </summary>
        /// <param name="luisServices">A dictionary of named <see cref="LuisRecognizer"/> instances for usage within the bot.</param>
        public BotServices(Dictionary<string, LuisRecognizer> luisServices)
        {
            LuisServices = luisServices ?? throw new ArgumentNullException(nameof(luisServices));
        }

        /// <summary>
        /// Gets the (potential) set of LUIS Services used.
        /// Given there can be multiple LUIS services used in a single bot,
        /// LuisServices is represented as a Dictionary.  This is also modeled in the
        /// ".bot" file since the elements are named (string).
        /// This sample only uses a single LUIS instance.
        /// </summary>
        /// <value>
        /// A <see cref="LuisRecognizer"/> client instance created based on configuration in the .bot file.
        /// </value>
        public Dictionary<string, LuisRecognizer> LuisServices { get; } = new Dictionary<string, LuisRecognizer>();
    }
}