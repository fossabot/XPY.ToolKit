﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XPY.ToolKit.Utilities.Common.Test {
    public class DateTimeExtensionTest {
        public static IEnumerable<object[]> TestDataSets1 =>
            new List<object[]>() {
                new object[]{ new DateTime(2000,1,5,5,1,2,DateTimeKind.Utc), 947048462 },
                new object[]{ new DateTime(2033,9,4,9,10,12,DateTimeKind.Utc), 2009437812 },
                new object[]{ new DateTime(1994,6,1,1,1,1,DateTimeKind.Utc), 770432461 },
                new object[]{ new DateTime(2019,1,1,0,0,0,DateTimeKind.Utc), 1546300800 },
            };

        public static IEnumerable<object[]> TestDataSets2 =>
            new List<object[]>() {
                new object[]{ new DateTime(2000,1,5,5,1,2,DateTimeKind.Utc), 947048462000 },
                new object[]{ new DateTime(2033,9,4,9,10,12,DateTimeKind.Utc), 2009437812000 },
                new object[]{ new DateTime(1994,6,1,1,1,1,DateTimeKind.Utc), 770432461000 },
                new object[]{ new DateTime(2019,1,1,0,0,0,DateTimeKind.Utc), 1546300800000 },
            };

        [Theory(DisplayName = "DateTime轉換為UnixTimestamp測試")]
        [MemberData(nameof(TestDataSets1))]
        public void ToUnixTimestampTest(DateTime datetime, long unixTimestamp) {
            Assert.Equal(unixTimestamp, datetime.ToUnixTimestamp());
        }

        [Theory(DisplayName = "DateTime轉換為UnixTimestampMilliseconds測試")]
        [MemberData(nameof(TestDataSets2))]
        public void ToUnixTimestampMillisecondsTest(DateTime datetime, long unixTimestampMilliseconds) {
            Assert.Equal(unixTimestampMilliseconds, datetime.ToUnixTimestampMilliseconds());
        }

        [Theory(DisplayName = "UnixTimestamp轉換為DateTime測試")]
        [MemberData(nameof(TestDataSets1))]
        public void FromUnixTimestampTest(DateTime datetime, long unixTimestamp) {
            Assert.Equal(datetime, unixTimestamp.ToDateTimeFromTimestamp());
        }

        [Theory(DisplayName = "UnixTimestampMilliseconds轉換為DateTime測試")]
        [MemberData(nameof(TestDataSets2))]
        public void FromUnixTimestampMillisecondsTest(DateTime datetime, long unixTimestampMilliseconds) {
            Assert.Equal(datetime, unixTimestampMilliseconds.ToDateTimeFromTimestampMilliseconds());
        }
    }
}
