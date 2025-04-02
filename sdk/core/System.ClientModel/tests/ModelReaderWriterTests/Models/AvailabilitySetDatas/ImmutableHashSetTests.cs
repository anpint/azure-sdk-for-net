﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;
using System.ClientModel.Tests.Client.Models.ResourceManager.Compute;
using System.Collections.Immutable;
using NUnit.Framework;

namespace System.ClientModel.Tests.ModelReaderWriterTests.Models.AvailabilitySetDatas
{
    public class ImmutableHashSetTests : MrwCollectionTests<ImmutableHashSet<AvailabilitySetData>, AvailabilitySetData>
    {
        protected override string GetJsonCollectionType() => "List";

        protected override string CollectionTypeName => "ImmutableHashSet<AvailabilitySetData>";

        protected override bool IsWriteOrderDeterministic => false;

        protected override bool IsRoundTripOrderDeterministic => false;

        protected override ModelReaderWriterContext Context => new LocalContext();

        protected override void CompareModels(AvailabilitySetData model, AvailabilitySetData model2, string format)
            => AvailabilitySetDataTests.CompareAvailabilitySetData(model, model2, format);

        protected override ImmutableHashSet<AvailabilitySetData> GetModelInstance()
            => ImmutableHashSet<AvailabilitySetData>.Empty.WithComparer(new AvailabilitySetDataComparer())
                .Add(ModelInstances.s_testAs_3375)
                .Add(ModelInstances.s_testAs_3376);

        protected override void CompareCollections(ImmutableHashSet<AvailabilitySetData> expected, ImmutableHashSet<AvailabilitySetData> actual, string format)
        {
            Assert.IsNotNull(expected);
            Assert.IsNotNull(actual);

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (var actualItem in actual)
            {
                Assert.IsTrue(expected.TryGetValue(actualItem, out AvailabilitySetData? expectedItem));
                CompareModels(expectedItem, actualItem, format);
            }
        }

#nullable disable
        public class LocalContext : ModelReaderWriterContext
        {
            private static readonly Lazy<TestClientModelReaderWriterContext> s_libraryContext = new(() => new());
            private ImmutableHashSet_AvailabilitySetData_Builder _immutableHashSet_AvailabilitySetData_Builder;

            protected override bool TryGetTypeBuilderCore(Type type, out ModelReaderWriterTypeBuilder builder)
            {
                builder = type switch
                {
                    Type t when t == typeof(ImmutableHashSet<AvailabilitySetData>) => _immutableHashSet_AvailabilitySetData_Builder ??= new(),
                    _ => GetFromDependencies(type)
                };
                return builder is not null;
            }

            private ModelReaderWriterTypeBuilder GetFromDependencies(Type type)
            {
                if (s_libraryContext.Value.TryGetTypeBuilder(type, out ModelReaderWriterTypeBuilder builder))
                    return builder;
                return null;
            }

            private class ImmutableHashSet_AvailabilitySetData_Builder : ModelReaderWriterTypeBuilder
            {
                protected override Type BuilderType => typeof(ImmutableHashSet<AvailabilitySetData>.Builder);

                protected override Type ItemType => typeof(AvailabilitySetData);

                protected override object CreateInstance() => ImmutableHashSet<AvailabilitySetData>.Empty.ToBuilder();

                protected override void AddItem(object collection, object item)
                    => ((ImmutableHashSet<AvailabilitySetData>.Builder)collection).Add((AvailabilitySetData)item);

                protected override object ToCollection(object builder)
                    => ((ImmutableHashSet<AvailabilitySetData>.Builder)builder).ToImmutable();
            }
        }
#nullable enable
    }
}
