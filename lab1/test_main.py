from main import addition, subtraction

def test_addition_positive():
    assert addition(2, 3) == 5

def test_addition_negative():
    assert addition(-2, 3) == 1

def test_addition_zero():
    assert addition(0, 5) == 5

def test_subtraction_positive():
    assert subtraction(2, 3) == -1

def test_subtraction_negative():
    assert subtraction(-2, 3) == -5

def test_subtraction_zero():
    assert subtraction(0, 5) == -5