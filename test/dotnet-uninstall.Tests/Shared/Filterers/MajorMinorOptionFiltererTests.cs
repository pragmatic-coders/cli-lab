﻿using System.Collections.Generic;
using System.CommandLine;
using Microsoft.DotNet.Tools.Uninstall.Shared.BundleInfo;
using Microsoft.DotNet.Tools.Uninstall.Shared.Configs;
using Microsoft.DotNet.Tools.Uninstall.Shared.Exceptions;
using Xunit;

namespace Microsoft.DotNet.Tools.Uninstall.Tests.Shared.Filterers
{
    public class MajorMinorOptionFiltererTests : FiltererTests
    {
        internal override Option Option => CommandLineConfigs.UninstallMajorMinorOption;
        internal override string DefaultArgValue => "2.2";
        internal override bool TestBundleTypeNotSpecifiedException => false;

        public static IEnumerable<object[]> GetDataForTestFiltererGood()
        {
            yield return new object[]
            {
                DefaultTestBundles,
                "2.1",
                new List<Bundle>
                {
                    Sdk_2_1_700_X64,
                    Sdk_2_1_300_Rc1_Arm32,
                    Sdk_2_1_300_Rc1_X86
                },
                BundleType.Sdk,
                DefaultTestArchSelection
            };

            yield return new object[]
            {
                DefaultTestBundles,
                "2.2",
                new List<Bundle>
                {
                    Runtime_2_2_5_Arm32,
                    Runtime_2_2_5_X86,
                    Runtime_2_2_4_X86,
                    Runtime_2_2_2_X64
                },
                BundleType.Runtime,
                DefaultTestArchSelection
            };

            yield return new object[]
            {
                DefaultTestBundles,
                "2.1",
                new List<Bundle>
                {
                    Sdk_2_1_700_X64,
                    Sdk_2_1_300_Rc1_Arm32,
                    Sdk_2_1_300_Rc1_X86,
                    Runtime_2_1_0_Rc1_X64
                },
                BundleType.Sdk | BundleType.Runtime,
                DefaultTestArchSelection
            };

            yield return new object[]
            {
                DefaultTestBundles,
                "2.2",
                new List<Bundle>
                {
                    Sdk_2_2_300_X64,
                    Sdk_2_2_222_X86,
                    Sdk_2_2_202_X86,
                    Sdk_2_2_202_Arm32,
                    Runtime_2_2_5_Arm32,
                    Runtime_2_2_5_X86,
                    Runtime_2_2_4_X86,
                    Runtime_2_2_2_X64
                },
                BundleType.Sdk | BundleType.Runtime,
                DefaultTestArchSelection
            };

            yield return new object[]
            {
                DefaultTestBundles,
                "2.5",
                new List<Bundle>(),
                BundleType.Sdk,
                DefaultTestArchSelection
            };

            yield return new object[]
            {
                DefaultTestBundles,
                "2.5",
                new List<Bundle>(),
                BundleType.Runtime,
                DefaultTestArchSelection
            };

            yield return new object[]
            {
                DefaultTestBundles,
                "2.5",
                new List<Bundle>(),
                BundleType.Sdk | BundleType.Runtime,
                DefaultTestArchSelection
            };

            yield return new object[]
            {
                DefaultTestBundles,
                "2.1",
                new List<Bundle>
                {
                    Sdk_2_1_300_Rc1_Arm32
                },
                BundleType.Sdk,
                BundleArch.Arm32
            };

            yield return new object[]
            {
                DefaultTestBundles,
                "2.2",
                new List<Bundle>
                {
                    Runtime_2_2_5_X86,
                    Runtime_2_2_4_X86
                },
                BundleType.Runtime,
                BundleArch.X86
            };

            yield return new object[]
            {
                DefaultTestBundles,
                "2.1",
                new List<Bundle>
                {
                    Sdk_2_1_700_X64,
                    Runtime_2_1_0_Rc1_X64
                },
                BundleType.Sdk | BundleType.Runtime,
                BundleArch.X64
            };

            yield return new object[]
            {
                DefaultTestBundles,
                "2.2",
                new List<Bundle>
                {
                    Sdk_2_2_300_X64,
                    Sdk_2_2_202_Arm32,
                    Runtime_2_2_5_Arm32,
                    Runtime_2_2_2_X64
                },
                BundleType.Sdk | BundleType.Runtime,
                BundleArch.X64 | BundleArch.Arm32
            };

            yield return new object[]
            {
                DefaultTestBundles,
                "2.5",
                new List<Bundle>(),
                BundleType.Sdk,
                BundleArch.Arm32
            };

            yield return new object[]
            {
                DefaultTestBundles,
                "2.5",
                new List<Bundle>(),
                BundleType.Runtime,
                BundleArch.X64 | BundleArch.X86
            };

            yield return new object[]
            {
                DefaultTestBundles,
                "2.5",
                new List<Bundle>(),
                BundleType.Sdk | BundleType.Runtime,
                BundleArch.X86 | BundleArch.Arm32
            };
        }

        [Theory]
        [MemberData(nameof(GetDataForTestFiltererGood))]
        internal void TestMajorMinorOptionFiltererGood(IEnumerable<Bundle> testBundles, string argValue, IEnumerable<Bundle> expected, BundleType typeSelection, BundleArch archSelection)
        {
            TestFiltererGood(testBundles, argValue, expected, typeSelection, archSelection);
        }

        [Theory]
        [InlineData("2")]
        [InlineData("2.")]
        [InlineData("2.2.")]
        [InlineData("2.2.2")]
        [InlineData("2.2.202")]
        [InlineData("a.0")]
        [InlineData("0.a")]
        [InlineData("2.2-preview")]
        [InlineData("2.2-preview-011768")]
        [InlineData("2.2-preview-011768-15")]
        [InlineData("3.0.0-preview5-27626-15")]
        [InlineData("3.0.100-preview5-011568")]
        internal void TestMajorMinorOptionFiltererInvalidInputVersionStringException(string argValue)
        {
            TestFiltererException<InvalidInputVersionException>(DefaultTestBundles, argValue, BundleType.Sdk | BundleType.Runtime, DefaultTestArchSelection);
        }
    }
}