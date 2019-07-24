using System;
using Moq;

namespace test1
{
   class Class1
   {
      private MockRepository mocks;

      public Class1()
      {
         mocks = new MockRepository(MockBehavior.Default);
      }
   }
}
