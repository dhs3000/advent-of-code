module _2023_AoC.test.Day1Test

open NUnit.Framework
open _2023_AoC.src

[<Test>]
let dummyMethodWorks() =
    let input = """
        1abc2
        pqr3stu8vwx
        a1b2c3d4e5f
        treb7uchet
        """
    let result = Day1.run input
    Assert.That(result, Is.EqualTo(142))
