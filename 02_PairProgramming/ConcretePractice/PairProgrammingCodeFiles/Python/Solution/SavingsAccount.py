import BankAccount


class SavingsAccount(BankAccount):
    def __init__(self, customer_name, account_no, balance, interest_rate):
        super().__init__(self, customer_name, account_no, balance)
        self.__interest_rate = interest_rate

    def withdraw(self, amt):
        new_balance = self.__balance - amt
        if new_balance > 0:
            self.__balance = new_balance

    def apply_interest(self):
        self.__balance *= self.__interest_rate
