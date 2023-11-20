# Demo .NET - Test patterns


- [1. Dummy](#1-dummy)
- [2. Stub](#2-stub)
- [3. Spy](#3-spy)
- [4. Mock](#4-mock)
- [5. Fake](#5-fake)



## 1. Dummy

Dummy is an object that is passed around but never used. It's only used to fill parameter lists.



## 2. Stub

Stub is an object that returns a value that is used by the test. It's used to control the indirect input of the test.



## 3. Spy

Spy is an object that records the indirect output of the test. It's used to control the indirect output of the test.



## 4. Mock

Mock is an object that verifies the indirect output of the test. It's used to verify the indirect output of the test. Mock is a mix of a stub and a spy.



## 5. Fake

Fake is an object that has a working implementation, but it's usually slower than the production one. It's used to replace a production object that is hard to use in a test environment.