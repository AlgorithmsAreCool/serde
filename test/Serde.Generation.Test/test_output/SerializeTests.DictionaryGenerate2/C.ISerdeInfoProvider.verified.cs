﻿//HintName: C.ISerdeInfoProvider.cs

#nullable enable
partial record C : Serde.ISerdeInfoProvider
{
    static global::Serde.ISerdeInfo global::Serde.ISerdeInfoProvider.SerdeInfo { get; } = Serde.SerdeInfo.MakeCustom(
        "C",
        new (string, global::Serde.ISerdeInfo, System.Reflection.MemberInfo)[] {
("x", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.Int32Wrap>(), typeof(C).GetProperty("X")!)
    });
}