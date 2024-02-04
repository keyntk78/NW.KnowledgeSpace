﻿using NW.KnowledgeSpace.Backend.Helpers;

namespace NW.KnowledgeSpace.Backend.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseErrorWrapping(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorWrappingMiddleware>();
        }
    }
}
