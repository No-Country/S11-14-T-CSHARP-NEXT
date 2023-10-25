import { Room } from '@components/templates/RoomsList';
import React, { useState } from 'react';

interface Props {
  roomsList: Room[];
  setSearchedRooms: React.Dispatch<React.SetStateAction<Room[]>>;
}

const SelectRoomFilter: React.FC<Props> = ({ roomsList, setSearchedRooms }) => {
  const [sortOption, setSortOption] = useState<string>('');

  const handleSortChange = (e: React.ChangeEvent<HTMLSelectElement>) => {
    const option = e.target.value;
    setSortOption(option);
    let orderedRooms = [...roomsList];

    switch (option) {
      case 'status':
        orderedRooms = orderedRooms.sort((a, b) => a.state.localeCompare(b.state));
        break;
      case 'type':
        orderedRooms = orderedRooms.sort((a, b) => a.type.localeCompare(b.type));
        break;
      case 'priceAsc':
        orderedRooms = orderedRooms.sort((a, b) => a.price - b.price);
        break;
      case 'priceDesc':
        orderedRooms = orderedRooms.sort((a, b) => b.price - a.price);
        break;
      default:
        orderedRooms = roomsList;
        break;
    }

    setSearchedRooms([...orderedRooms]);
  };
  return (
    <div className='flex items-center gap-x-4 justify-start'>
      <span className='text-neutral-500'>Ordenar por:</span>
      <select
        className='bg-transparent border-none text-neutral-500 font-medium outline-none filterOptions'
        value={sortOption}
        onChange={handleSortChange}
      >
        <option value='status'>Estado</option>
        <option value='type'>Tipo</option>
        <option value='priceAsc'>Precio ascendente</option>
        <option value='priceDesc'>Precio descendente</option>
      </select>
    </div>
  );
};

export default SelectRoomFilter;
