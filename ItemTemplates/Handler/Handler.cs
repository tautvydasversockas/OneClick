using System;
using System.Threading;
using System.Threading.Tasks;
using Serilog;

namespace $rootnamespace$.$fileinputname$
{
    public class $fileinputname$Handler
    {
        private readonly ILogger _logger;
        private readonly $fileinputname$HandlerSettings _settings;

        public $fileinputname$Handler(
            $fileinputname$HandlerSettings settings,
            ILogger logger)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task HandleAsync(MyMessage message, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.CompletedTask;
        }
    }
}