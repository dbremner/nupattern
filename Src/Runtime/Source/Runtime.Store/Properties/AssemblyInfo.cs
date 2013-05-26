using System;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: AssemblyTitle(@"NuPattern.Runtime.RuntimeStore")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]

[assembly: CLSCompliant(true)]

[assembly: InternalsVisibleTo(@"NuPattern.Runtime.Core, PublicKey=00240000048000001401000006020000002400005253413100080000010001007beac0181d1669e636e92b9c5e54bd5fc1fd788892cbaa578d72a4a714a90d3a9d7eb67d976e216fe12435b42add0e9996668a611d761f48a872ff5c89d774f9d0efd7d6962c1bff84e2ce8229539f4da66204c7844511990057c6959fd62b5ce2a0c265ea633f4cd3ae1f292aefdb00b266c863f476f3c574573bb1bd36a8fa19d0de443658c262ecea16e7e502883ae071617300a6369a5b8590b71348c2053de41ab7a993a247443e010ebfafb2a21507d26334e968afa3bfbb47e10d9d0f9fd95d3d158e4645cf1d89c304792765e65904eb6be2be355e76d58756155ffa44fac32dd49ff7850bc1697b9ebde597a94d19f5f5131ce63e8a5f08bae616db")]
[assembly: InternalsVisibleTo(@"NuPattern.Runtime.UnitTests, PublicKey=00240000048000001401000006020000002400005253413100080000010001007beac0181d1669e636e92b9c5e54bd5fc1fd788892cbaa578d72a4a714a90d3a9d7eb67d976e216fe12435b42add0e9996668a611d761f48a872ff5c89d774f9d0efd7d6962c1bff84e2ce8229539f4da66204c7844511990057c6959fd62b5ce2a0c265ea633f4cd3ae1f292aefdb00b266c863f476f3c574573bb1bd36a8fa19d0de443658c262ecea16e7e502883ae071617300a6369a5b8590b71348c2053de41ab7a993a247443e010ebfafb2a21507d26334e968afa3bfbb47e10d9d0f9fd95d3d158e4645cf1d89c304792765e65904eb6be2be355e76d58756155ffa44fac32dd49ff7850bc1697b9ebde597a94d19f5f5131ce63e8a5f08bae616db")]
[assembly: InternalsVisibleTo(@"NuPattern.Runtime.IntegrationTests, PublicKey=00240000048000001401000006020000002400005253413100080000010001007beac0181d1669e636e92b9c5e54bd5fc1fd788892cbaa578d72a4a714a90d3a9d7eb67d976e216fe12435b42add0e9996668a611d761f48a872ff5c89d774f9d0efd7d6962c1bff84e2ce8229539f4da66204c7844511990057c6959fd62b5ce2a0c265ea633f4cd3ae1f292aefdb00b266c863f476f3c574573bb1bd36a8fa19d0de443658c262ecea16e7e502883ae071617300a6369a5b8590b71348c2053de41ab7a993a247443e010ebfafb2a21507d26334e968afa3bfbb47e10d9d0f9fd95d3d158e4645cf1d89c304792765e65904eb6be2be355e76d58756155ffa44fac32dd49ff7850bc1697b9ebde597a94d19f5f5131ce63e8a5f08bae616db")]
[assembly: InternalsVisibleTo(@"NuPattern.Runtime.Extensibility.UnitTests, PublicKey=00240000048000001401000006020000002400005253413100080000010001007beac0181d1669e636e92b9c5e54bd5fc1fd788892cbaa578d72a4a714a90d3a9d7eb67d976e216fe12435b42add0e9996668a611d761f48a872ff5c89d774f9d0efd7d6962c1bff84e2ce8229539f4da66204c7844511990057c6959fd62b5ce2a0c265ea633f4cd3ae1f292aefdb00b266c863f476f3c574573bb1bd36a8fa19d0de443658c262ecea16e7e502883ae071617300a6369a5b8590b71348c2053de41ab7a993a247443e010ebfafb2a21507d26334e968afa3bfbb47e10d9d0f9fd95d3d158e4645cf1d89c304792765e65904eb6be2be355e76d58756155ffa44fac32dd49ff7850bc1697b9ebde597a94d19f5f5131ce63e8a5f08bae616db")]
[assembly: InternalsVisibleTo(@"NuPattern.Runtime.Extensibility.IntegrationTests, PublicKey=00240000048000001401000006020000002400005253413100080000010001007beac0181d1669e636e92b9c5e54bd5fc1fd788892cbaa578d72a4a714a90d3a9d7eb67d976e216fe12435b42add0e9996668a611d761f48a872ff5c89d774f9d0efd7d6962c1bff84e2ce8229539f4da66204c7844511990057c6959fd62b5ce2a0c265ea633f4cd3ae1f292aefdb00b266c863f476f3c574573bb1bd36a8fa19d0de443658c262ecea16e7e502883ae071617300a6369a5b8590b71348c2053de41ab7a993a247443e010ebfafb2a21507d26334e968afa3bfbb47e10d9d0f9fd95d3d158e4645cf1d89c304792765e65904eb6be2be355e76d58756155ffa44fac32dd49ff7850bc1697b9ebde597a94d19f5f5131ce63e8a5f08bae616db")]
[assembly: InternalsVisibleTo(@"NuPattern.Library.UnitTests, PublicKey=00240000048000001401000006020000002400005253413100080000010001007beac0181d1669e636e92b9c5e54bd5fc1fd788892cbaa578d72a4a714a90d3a9d7eb67d976e216fe12435b42add0e9996668a611d761f48a872ff5c89d774f9d0efd7d6962c1bff84e2ce8229539f4da66204c7844511990057c6959fd62b5ce2a0c265ea633f4cd3ae1f292aefdb00b266c863f476f3c574573bb1bd36a8fa19d0de443658c262ecea16e7e502883ae071617300a6369a5b8590b71348c2053de41ab7a993a247443e010ebfafb2a21507d26334e968afa3bfbb47e10d9d0f9fd95d3d158e4645cf1d89c304792765e65904eb6be2be355e76d58756155ffa44fac32dd49ff7850bc1697b9ebde597a94d19f5f5131ce63e8a5f08bae616db")]
[assembly: InternalsVisibleTo(@"NuPattern.Library.IntegrationTests, PublicKey=00240000048000001401000006020000002400005253413100080000010001007beac0181d1669e636e92b9c5e54bd5fc1fd788892cbaa578d72a4a714a90d3a9d7eb67d976e216fe12435b42add0e9996668a611d761f48a872ff5c89d774f9d0efd7d6962c1bff84e2ce8229539f4da66204c7844511990057c6959fd62b5ce2a0c265ea633f4cd3ae1f292aefdb00b266c863f476f3c574573bb1bd36a8fa19d0de443658c262ecea16e7e502883ae071617300a6369a5b8590b71348c2053de41ab7a993a247443e010ebfafb2a21507d26334e968afa3bfbb47e10d9d0f9fd95d3d158e4645cf1d89c304792765e65904eb6be2be355e76d58756155ffa44fac32dd49ff7850bc1697b9ebde597a94d19f5f5131ce63e8a5f08bae616db")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2,PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484cf7045cc7")]