from lab1 import addition

def test_addition_positive():
    assert addition(2, 3) == 6

def test_addition_negative():
    assert addition(-2, 3) == -6

def test_addition_zero():
    assert addition(0, 5) == 0

def test_subtraction_positive():
    assert addition(6, 2) == 4

def test_subtraction_negative():
    assert addition(2, -10) == -8

def test_subtraction_zero():
    assert addition(0, 7) == -7
