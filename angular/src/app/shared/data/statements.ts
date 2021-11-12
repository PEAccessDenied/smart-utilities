export interface Statement {
  date: string;
  fullName: string;
  status: string;
  amount: number;
}

export const statements: Statement[] = [
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
  }, {
    date: new Date().toISOString(),
    fullName: "Wilder Gonzales",
    status: "Pending",
    amount: 545
  },
  {
    date: new Date().toISOString(),
    fullName: "Georgina Schultz",
    status: "Unpaid",
    amount: 232
  },
  {
    date: new Date().toISOString(),
    fullName: "Carroll Buchanan",
    status: "Unpaid",
    amount: 100
  }, {
    date: new Date().toISOString(),
    fullName: "Valarie Atkinson",
    status: "Unpaid",
    amount: 43
  }, {
    date: new Date().toISOString(),
    fullName: "Schroeder Mathews",
    status: "Paid",
    amount: 100
  }, {
    date: new Date().toISOString(),
    fullName: "Lynda Mendoza",
    status: "Pending",
    amount: 130
  },
  {
    date: new Date().toISOString(),
    fullName: "Sarah Massey",
    status: "Unpaid",
    amount: 110
  },
  {
    date: new Date().toISOString(),
    fullName: "Robles Boyle",
    status: "Paid",
    amount: 310
  },
  {
    date: new Date().toISOString(),
    fullName: "Evans Hickman",
    status: "Pending",
    amount: 100
  },
  {
    date: new Date().toISOString(),
    fullName: "Dawson Barber",
    status: "Paid",
    amount: 150
  },
  {
    date: new Date().toISOString(),
    fullName: "Bruce Strong",
    status: "Unpaid",
    amount: 100
  },
  {
    date: new Date().toISOString(),
    fullName: "Nellie Whitfield",
    status: "Paid",
    amount: 10
  },
  {
    date: new Date().toISOString(),
    fullName: "Jackson Macias",
    status: "Paid",
    amount: 100
  },
  {
    date: new Date().toISOString(),
    fullName: "Pena Pena",
    status: "Paid",
    amount: 0.0
  },
  {
    date: new Date().toISOString(),
    fullName: "Lelia Gates",
    status: "Paid",
    amount: 32
  },
  {
    date: new Date().toISOString(),
    fullName: "Letitia Vasquez",
    status: "Pending",
    amount: 434
  },
  {
    date: new Date().toISOString(),
    fullName: "Trevino Moreno",
    status: "Pending",
    amount: 53
  },
  {
    date: new Date().toISOString(),
    fullName: "Barr Page",
    status: "Unpaid",
    amount: 43
  },
  {
    date: new Date().toISOString(),
    fullName: "Kirkland Merrill",
    status: "Paid",
    amount: 0.0
  },
  {
    date: new Date().toISOString(),
    fullName: "Blanche Conley",
    status: "Paid",
    amount: 54
  }
];
