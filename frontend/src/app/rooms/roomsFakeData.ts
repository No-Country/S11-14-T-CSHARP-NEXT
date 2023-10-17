interface Room {
  image: string;
  roomNumber: string;
  type: RoomType;
  beds: number;
  capacity: number;
  status: Status;
  checkIn?: string;
  checkOut?: string;
  pricePerNight: number;
}

type RoomType = 'Estándar' | 'Doble' | 'Suite' | 'Individual';
type Status = 'Disponible' | 'Ocupada' | 'Reparación';

export const roomsFakeData: Room[] = [
  {
    image: 'url_imagen_1',
    roomNumber: 'A-103',
    type: 'Suite',
    beds: 1,
    capacity: 2,
    status: 'Disponible',
    pricePerNight: 150,
  },
  {
    image: 'url_imagen_2',
    roomNumber: 'A-102',
    type: 'Doble',
    beds: 2,
    capacity: 2,
    status: 'Reparación',
    pricePerNight: 100,
  },
  {
    image: 'url_imagen_3',
    roomNumber: 'B-101',
    type: 'Estándar',
    beds: 1,
    capacity: 1,
    status: 'Ocupada',
    checkIn: '01/10/2023',
    checkOut: '10/10/2023',
    pricePerNight: 80,
  },
  {
    image: 'url_imagen_4',
    roomNumber: 'C-201',
    type: 'Suite',
    beds: 2,
    capacity: 4,
    status: 'Disponible',
    pricePerNight: 180,
  },
  {
    image: 'url_imagen_5',
    roomNumber: 'D-301',
    type: 'Individual',
    beds: 1,
    capacity: 1,
    status: 'Disponible',
    pricePerNight: 70,
  },
];
