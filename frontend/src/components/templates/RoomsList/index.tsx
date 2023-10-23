'use client';
import React, { useEffect, useState } from 'react';
import { ArrowRight, PlusIcon } from '@components/atoms/Icons';
import Button from '@components/atoms/Button';
import httpClient from '@libs/httpClient';
import RoomsTable from '@components/organisms/RoomsTable';
import SearchRoomInput from '@components/molecules/SearchRoomInput';
import SelectRoomFilter from '@components/molecules/SelectRoomFilter';

export interface Room {
  roomId: number;
  roomNumber: string;
  type: string;
  capacity: number;
  state: string;
  description: string;
  imageUrl: string;
  price: number;
}

const RoomsList: React.FC = () => {
  const [roomsList, setRoomsList] = useState<Room[]>([]);
  const [searchedRooms, setSearchedRooms] = useState<Room[]>([]);

  useEffect(() => {
    const fetchRoomsList = async () => {
      try {
        const response = await httpClient.get('/room');
        if (response.status === 200) {
          const data: Room[] = await response.data;
          setRoomsList(data);
          setSearchedRooms(data);
        } else {
          throw new Error('Error fetching rooms list');
        }
      } catch (error) {
        console.log(error);
      }
    };
    fetchRoomsList();
  }, []);

  return (
    <div className='min-h-screen flex flex-col gap-y-6'>
      <h1 className='font-medium text-3xl'>Habitaciones</h1>
      <div className='flex items-center justify-between'>
        <SearchRoomInput roomsList={roomsList} setSearchedRooms={setSearchedRooms} />
        <Button
          icon={<PlusIcon className='text-white' />}
          text='Crear habitación'
          type='button'
          className='bg-violet-500 text-white flex items-center gap-2 px-8 py-2 rounded w-fit'
        />
      </div>
      <SelectRoomFilter roomsList={roomsList} setSearchedRooms={setSearchedRooms} />
      <section className='flex flex-col gap-y-4'>
        {searchedRooms && <RoomsTable searchedRooms={searchedRooms} />}
      </section>
      <div className='flex items-center justify-end'>
        {/* Provisional hasta determinar el paginado */}
        <div className='flex items-center gap-2'>
          <span>1</span>
          <span>2</span>
          <span>3</span>
          <ArrowRight size='sm' className='text-neutral-600 h-6 w-6' />
        </div>
      </div>
    </div>
  );
};

export default RoomsList;
