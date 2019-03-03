using System;
using System.Threading;
using System.Threading.Tasks;
using Serilog;

namespace $rootnamespace$.$fileinputname$
{
    public class $fileinputname$RequestHandler
    {
        private readonly ILogger _logger;
        private readonly $fileinputname$RequestHandlerSettings _settings;

        public $fileinputname$RequestHandler(
            $fileinputname$RequestHandlerSettings settings,
            ILogger logger)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task HandleAsync($fileinputname$Request request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.CompletedTask;
        }
    }
}