using System;
using System.Threading;
using System.Threading.Tasks;
using Serilog;

namespace $rootnamespace$.$fileinputname$
{
    public class $fileinputname$CommandHandler
    {
        private readonly ILogger _logger;
        private readonly $fileinputname$CommandHandlerSettings _settings;

        public $fileinputname$CommandHandler(
            $fileinputname$CommandHandlerSettings settings,
            ILogger logger)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task HandleAsync($fileinputname$Command request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.CompletedTask;
        }
    }
}