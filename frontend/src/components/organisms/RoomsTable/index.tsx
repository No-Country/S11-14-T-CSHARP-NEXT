import { Room } from '@components/templates/RoomsList';
import TableRow from '@components/molecules/TableRow';
import React from 'react';
interface Props {
  searchedRooms: Room[];
}
const RoomsTable: React.FC<Props> = ({ searchedRooms }) => {
  return (
    <table className='bg-white rounded-lg table-auto'>
      <thead>
        <tr className='table-row'>
          <th className='table-header'>
            <input type='checkbox' />
          </th>
          <th className='table-header'>Imagen</th>
          <th className='table-header'>Habitación Nº</th>
          <th className='table-header'>Tipo</th>
          <th className='table-header'>Capacidad</th>
          <th className='table-header'>Estado</th>
          <th className='table-header'>Precio/noche</th>
          <th className='table-header'>Acción</th>
        </tr>
      </thead>
      <tbody>
        {searchedRooms && searchedRooms.map((room) => <TableRow key={room.roomId} room={room} />)}
      </tbody>
    </table>
  );
};

export default RoomsTable;
