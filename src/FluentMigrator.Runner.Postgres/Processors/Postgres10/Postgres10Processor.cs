#region License
//
// Copyright (c) 2019, Fluent Migrator Project
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using System.Collections.Generic;

using FluentMigrator.Runner.Generators.Postgres10;
using FluentMigrator.Runner.Initialization;
using FluentMigrator.Runner.Processors.Postgres;

using JetBrains.Annotations;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FluentMigrator.Runner.Processors.Postgres10
{
    public class Postgres10Processor : PostgresProcessor
    {
        public override string DatabaseType => "Postgres10";

        public override IList<string> DatabaseTypeAliases { get; } = new List<string> { "PostgreSQL10", "PostgreSQL" };

        public Postgres10Processor(
            [NotNull] PostgresDbFactory factory,
            [NotNull] Postgres10Generator generator,
            [NotNull] ILogger<PostgresProcessor> logger,
            [NotNull] IOptionsSnapshot<ProcessorOptions> options,
            [NotNull] IConnectionStringAccessor connectionStringAccessor,
            [NotNull] PostgresOptions pgOptions)
            : base(factory, generator, logger, options, connectionStringAccessor, pgOptions)
        {
        }
    }
}
