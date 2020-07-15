import BankAccount


class CurrentAccount(BankAccount):
    def __init__(self, customer_name, account_no, balance, overdraft_limit):
        super().__init__(self, customer_name, account_no, balance)
        if overdraft_limit <= 0:
            self.__overdraft_limit = overdraft_limit
        else:
            self.__overdraft_limit = 0

    def withdraw(self, amt):
        new_balance = self.__balance - amt
        if self.__overdraft_limit < new_balance:
            self.__balance = new_balance
