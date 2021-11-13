export interface CitizenStatement {
  date: string;
  fullName: string;
  status: string;
  amountDue: string;
}

export interface SupplierStatement {
  date: string;
  fullName: string;
  status: string;
  amount: number;
}

export const citizenStatements: CitizenStatement[] = [
  {
    date: new Date().toISOString(),
    fullName: "Ethel Price",
    status: "Paid",
    amountDue: "R 223.43"
  },
  {
    date: new Date().toISOString(),
    fullName: "Claudine Neal",
    status: "Paid",
    amountDue: "R 55"
  },
  {
    date: new Date().toISOString(),
    fullName: "Beryl Rice",
    status: "Overdue",
    amountDue: "R 67"
  },
];

export const supplierStatements: SupplierStatement[] = [
  {
    date: new Date().toISOString(),
    fullName: "Ethel Price",
    status: "Paid",
    amount: 223.43
  },
  {
    date: new Date().toISOString(),
    fullName: "Claudine Neal",
    status: "Paid",
    amount: 55
  }, {
    date: new Date().toISOString(),
    fullName: "Beryl Rice",
    status: "Overdue",
    amount: 67
  },
];
