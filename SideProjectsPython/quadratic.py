import math
num1 = int(input("Enter a:"))
num2 = int(input("Enter b:"))
num3 = int(input("Enter c:"))
result1 = (-num2 + math.sqrt(num2**2 - 4 * (num1) * (num3)))
result2 = (result1 / (2 * num1))
print("Positive: ")
print(result2)
print("-------------------------------------------------------------")
print("Negative: ")
result3 = (-num2 - math.sqrt(num2**2 - 4 * (num1) * (num3)))
result4 = (result3 / (2 * num1))
print(result4)

