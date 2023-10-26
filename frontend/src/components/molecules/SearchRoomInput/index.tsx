'use client';
import { Room } from '@components/templates/RoomsList';
import { SearchIcon } from '@components/atoms/Icons';
import React, { useEffect, useState } from 'react';

interface Props {
  roomsList: Room[];
  setSearchedRooms: React.Dispatch<React.SetStateAction<Room[]>>;
}
const SearchRoomInput: React.FC<Props> = ({ roomsList, setSearchedRooms }) => {
  const [roomSearched, setRoomSearched] = useState<string>('');

  useEffect(() => {
    if (!roomSearched) {
      return;
    }

    if (!roomsList) {
      return;
    }

    const filteredRooms = roomsList?.filter((room) => {
      return (
        room.state.toLowerCase().includes(roomSearched.toLowerCase()) ||
        room.type.toLowerCase().includes(roomSearched.toLowerCase())
      );
    });
    setSearchedRooms(filteredRooms);
  }, [roomSearched]);

  return (
    <div className='relative flex items-center'>
      <SearchIcon className='absolute left-4 text-neutral-500' />
      <input
        className='bg-white text-neutral-500 pl-10 pr-4 placeholder:font-medium py-2 rounded-lg outline-violet-500'
        type='text'
        name='searcher'
        value={roomSearched}
        onChange={(e) => setRoomSearched(e.target.value)}
        placeholder='Buscar habitación por tipo o estado'
      />
    </div>
  );
};

export default SearchRoomInput;
