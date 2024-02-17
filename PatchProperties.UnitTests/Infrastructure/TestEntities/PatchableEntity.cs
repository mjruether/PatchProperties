namespace PatchProperties.UnitTests.Infrastructure.TestEntities
{
    /// <summary>
    /// Entity with all the types that can be patched.
    /// Intended for use in unit tests.
    /// </summary>
    public class PatchableEntity
    {
        #region Bool

        public int SomeBool { get; set; }

        public int? SomeNullableBool { get; set; }

        #endregion

        #region Byte
           
        public byte SomeByte { get; set; }

        public byte? SomeNullableByte { get; set; }

        #endregion

        #region Char

        public char SomeChar { get; set; }

        public char? SomeNullableChar { get; set; }

        #endregion

        #region DateTime

        public DateTime SomeDateTime { get; set; }

        public DateTime? SomeNullableDateTime { get; set; }

        #endregion

        #region Decimal

        public decimal SomeDecimal { get; set; }

        public decimal? SomeNullableDecimal { get; set; }

        #endregion

        #region Double

        public double SomeDouble { get; set; }

        public double? SomeNullableDouble { get; set; }

        #endregion

        #region Float

        public float SomeFloat { get; set; }

        public float? SomeNullableFloat { get; set; }

        #endregion

        //#region Generic

        //public SomeType SomeGeneric { get; set; }

        //public SomeType? SomeNullableGeneric { get; set; }

        //#endregion

        #region Int

        public int SomeInt { get; set; }

        public int? SomeNullableInt { get; set; }

        public int MisTypedInt { get; set; }

        #endregion

        #region List

        public List<int> SomeList { get; set;}

        #endregion

        #region Long

        public long SomeLong { get; set; }

        public long? SomeNullableLong { get; set; }

        #endregion

        #region SByte

        public sbyte SomeSByte { get; set; }

        public sbyte? SomeNullableSByte { get; set; }

        #endregion

        #region Short

        public short SomeShort { get; set; }

        public short? SomeNullableShort { get; set; }

        #endregion
        
        #region String

        public string SomeString { get; set; }

        #endregion

        #region UInt

        public uint SomeUInt { get; set; }

        public uint? SomeNullableUInt { get; set; }

        #endregion

        #region ULong

        public ulong SomeULong { get; set; }

        public ulong? SomeNullableULong { get; set; }

        #endregion

        #region UShort

        public ushort SomeUShort { get; set; }

        public ushort? SomeNullableUShort { get; set; }

        #endregion
    }
}
