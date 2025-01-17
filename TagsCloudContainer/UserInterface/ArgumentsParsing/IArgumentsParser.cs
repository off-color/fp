﻿using ResultOf;
using TagsCloudContainer.Core;

namespace TagsCloudContainer.UserInterface.ArgumentsParsing
{
    public interface IArgumentsParser<in TArguments>
    {
        Result<Parameters> ParseArgumentsToParameters(TArguments arguments);
    }
}