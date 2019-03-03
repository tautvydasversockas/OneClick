using System;
using System.Threading;
using System.Threading.Tasks;
using Serilog;

namespace $rootnamespace$.$fileinputname$
{
    public class $fileinputname$QueryHandler
    {
        private readonly ILogger _logger;
        private readonly $fileinputname$QueryHandlerSettings _settings;

        public $fileinputname$QueryHandler(
            $fileinputname$QueryHandlerSettings settings,
            ILogger logger)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task<int> HandleAsync($fileinputname$Query request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult(42);
        }
    }
}