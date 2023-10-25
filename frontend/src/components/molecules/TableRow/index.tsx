import { Room } from '@components/templates/RoomsList';
import { EditIcon } from '@components/atoms/Icons';
import StatusTag from '@components/atoms/StatusTag';
import Link from 'next/link';
import React from 'react';

interface Props {
  room: Room;
}
const TableRow: React.FC<Props> = ({ room }) => {
  const { roomNumber, type, capacity, state, imageUrl, price } = room;
  return (
    <tr className='table-row'>
      <td className='table-td'>
        <input type='checkbox' />
      </td>
      <td className='table-td grid place-content-center'>
        <img src={imageUrl} alt={roomNumber} className='w-20 h-10' />
      </td>
      <td className='table-td'>{roomNumber}</td>
      <td className='table-td'>{type}</td>
      <td className='table-td'>{capacity}</td>
      <td className='table-td'>
        <StatusTag status={state} />
      </td>
      <td className='table-td'>${price}</td>
      <td className='table-td flex items-center justify-center'>
        <Link href={`/rooms/${roomNumber}`}>
          <EditIcon className='text-violet-500' size='24' />
        </Link>
      </td>
    </tr>
  );
};

export default TableRow;
