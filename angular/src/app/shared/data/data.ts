

const suppliers = [
  {
    id: 1,
    phone: '043 405 54065',
    areasServed: 22,
    company: 'Johnson LLC CMP DDC',
  },
  {
    id: 2,
    phone: '043 405 54065',
    areasServed: 55,
    company: 'Sealoud'
  },
  {
    id: 3,
    phone: '043 405 54065',
    areasServed: 67,
    company: 'Velity',
  },
  {
    id: 4,
    phone: '043 405 54065',
    areasServed: 34,
    company: 'Geekko'
  },
  {
    id: 5,
    phone: '043 405 54065',
    areasServed: 5,
    company: 'Suretech'
  },
  {
    id: 6,
    phone: '043 405 54065',
    areasServed: 11,
    company: 'Ecosys'
  },
  {
    id: 7,
    phone: '043 405 54065',
    areasServed: 13,
    company: 'Hopeli'
  },
  {
    id: 8,
    phone: '043 405 54065',
    areasServed: 11,
    company: 'Polarium'
  },
  {
    id: 9,
    phone: '043 405 54065',
    areasServed: 6,
    company: 'Dogspa'
  },
  {
    id: 10,
    phone: '043 405 54065',
    areasServed: 4,
    company: 'Bisba'
  }
];

const properties =
  [
    {
      id: 0,
      owner: "Ramsey Cummings",
      gender: "male",
      age: 52,
      address: "123 South Carolina",
      location: "Glendale"
    },
    {
      id: 1,
      owner: "Stefanie Huff",
      gender: "female",
      age: 70,
      address: " 124 Arizona",
      location: "Beaverdale"
    },
    {
      id: 2,
      owner: "Mabel David",
      gender: "female",
      age: 52,
      address: "123 New Mexico",
      location: "Grazierville"
    },
    {
      id: 3,
      owner: "Frank Bradford",
      gender: "male",
      age: 61,
      address: "125 Wisconsin",
      location: "Saranap"
    },
    {
      id: 4,
      owner: "Forbes Levine",
      gender: "male",
      age: 34,
      address: "234 Vermont",
      location: "Norris"
    },
    {
      id: 5,
      owner: "Santiago Mcclain",
      gender: "male",
      age: 38,
      address: "231 Montana",
      location: "Bordelonville"
    }, {
      id: 6,
      owner: "Merritt Booker",
      gender: "male",
      age: 33,
      address: "987 New Jersey",
      location: "Aguila"
    }, {
      id: 7,
      owner: "Oconnor Wade",
      gender: "male",
      age: 18,
      address: "198 Virginia",
      location: "Kenmar"
    }, {
      id: 8,
      owner: "Leigh Beasley",
      gender: "female",
      age: 53,
      address: "324 Texas",
      location: "Alfarata"
    },
    {
      id: 9,
      owner: "Johns Wood",
      gender: "male",
      age: 52,
      address: "545 Maine",
      location: "Witmer"
    }

  ];


const smartMeters = [
  {
    id: "A- 0010 - Z",
    owner: "Johns Wood",
    dateIssued: new Date().toISOString(),
    usage: 23453
  },
  {
    id: "A - 0020 - Z",
    owner: "Leigh Beasley",
    dateIssued: new Date().toISOString(),
    usage: 23453
  },
  {
    id: "A - 0030 - Z",
    owner: "Oconnor Wade",
    dateIssued: new Date().toISOString(),
    usage: 23453
  },
  {
    id: "A - 0040 - Z",
    owner: "Merritt Booker",
    dateIssued: new Date().toISOString(),
    usage: 23453
  },
  {
    id: "A - 0050 - Z",
    owner: "Santiago Mcclain",
    dateIssued: new Date().toISOString(),
    usage: 23453
  },
  {
    id: "A - 0060 - Z",
    owner: "Forbes Levine",
    dateIssued: new Date().toISOString(),
    usage: 23453
  },
  {
    id: "A - 0070 - Z",
    owner: "Frank Bradford",
    dateIssued: new Date().toISOString(),
    usage: 23453
  },
  {
    id: "A - 0080 - Z",
    owner: "Mabel David",
    dateIssued: new Date().toISOString(),
    usage: 23453
  },
  {
    id: "A - 0090 - Z",
    owner: "Stefanie Huff",
    dateIssued: new Date().toISOString(),
    usage: 23453
  },
  {
    id: "A - 0100 - Z",
    owner: "Ramsey Cummings",
    dateIssued: new Date().toISOString(),
    usage: 23453
  }
]

const resources = [
  {
    id: 1,
    category: "Reservoir",
    resourceType: "Fixed",
    name: "Elangeni",
    location: "East London",
    wards: 3,
    capacity: 19908,
  },
  {
    id: 2,
    category: "Dam",
    resourceType: "Fixed",
    name: "Emthonjeni",
    location: "Gqeberha",
    wards: 6,
    capacity: 18904,
  },
]
export { suppliers, properties, smartMeters, resources };
