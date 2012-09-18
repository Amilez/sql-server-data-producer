﻿// Copyright 2012 Peter Henell

//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at

//       http://www.apache.org/licenses/LICENSE-2.0

//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

using System.Threading;

namespace SQLDataProducer.Entities.Factories
{
    public static class GenerationNumberSupplier
    {
        static int _number;

        static GenerationNumberSupplier()
        {
            _number = 1;
        }

        public static int GetNextNumber()
        {
            return Interlocked.Increment(ref _number);
        }

        public static void Reset()
        {
            _number = 1;
        }

        public static int CurrentNumber()
        {
            return _number;
        }
    }
}