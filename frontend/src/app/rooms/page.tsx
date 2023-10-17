import { NextPage } from 'next';
import React from 'react';
import { roomsFakeData } from './roomsFakeData';
import StatusTag from '@components/atoms/StatusTag';
import { SearchIcon, PlusIcon, EditIcon } from '@components/atoms/Icons';
const RoomsPage: NextPage = () => {
  return (
    <div className='min-h-screen flex flex-col gap-y-6'>
      <h1 className='font-medium text-3xl'>Habitaciones</h1>
      <div className='flex items-center justify-between'>
        <div className='relative flex items-center'>
          <SearchIcon className='absolute left-4 text-neutral-500' />
          <input
            className='bg-white text-neutral-500 px-10 placeholder:font-medium py-2 rounded-lg outline-violet-500'
            type='text'
            name='searcher'
            placeholder='Buscar habitación'
          />
        </div>
        <button className='bg-violet-500 text-white flex items-center gap-2 px-8 py-2 rounded w-fit'>
          <PlusIcon className='text-white' /> Crear habitación
        </button>
      </div>
      <div className='flex items-center justify-start'>
        <p className='text-neutral-500'>
          Ordenar por: <span className='font-medium'>Habitación Nº</span>
        </p>
      </div>
      <section className='flex flex-col gap-y-4'>
        <table className='bg-white rounded-lg '>
          <tr className='text-sm font-medium border-b-1 border-neutral-200'>
            <th className='px-4 py-4 text-neutral-700 text-center'>[]</th>
            <th className='px-4 py-4 text-neutral-700 text-center'>Imagen</th>
            <th className='px-4 py-4 text-neutral-700 text-center'>Habitación Nº</th>
            <th className='px-4 py-4 text-neutral-700 text-center'>Tipo</th>
            <th className='px-4 py-4 text-neutral-700 text-center'>Camas</th>
            <th className='px-4 py-4 text-neutral-700 text-center'>Capacidad</th>
            <th className='px-4 py-4 text-neutral-700 text-center'>Status</th>
            <th className='px-4 py-4 text-neutral-700 text-center'>Check In</th>
            <th className='px-4 py-4 text-neutral-700 text-center'>Check Out</th>
            <th className='px-4 py-4 text-neutral-700 text-center'>Precio/noche</th>
            <th className='px-4 py-4 text-neutral-700 text-center'>Acción</th>
          </tr>

          {roomsFakeData.map((room, index) => (
            <tr className='text-sm border-b-1 border-neutral-200'>
              <td className='px-4 py-4 text-neutral-700 text-center'>{index + 1}</td>
              <td className='px-4 py-4 text-neutral-700 text-center'>{room.image}</td>
              <td className='px-4 py-4 text-neutral-700 text-center'>{room.roomNumber}</td>
              <td className='px-4 py-4 text-neutral-700 text-center'>{room.type}</td>
              <td className='px-4 py-4 text-neutral-700 text-center'>{room.beds}</td>
              <td className='px-4 py-4 text-neutral-700 text-center'>{room.capacity}</td>
              <td className='px-4 py-4 text-neutral-700 text-center'>
                <StatusTag status={room.status} />
              </td>
              <td className='px-4 py-4 text-neutral-700 text-center'>
                {room.checkIn ? room.checkIn : 'Check In'}
              </td>
              <td className='px-4 py-4 text-neutral-700 text-center'>
                {room.checkOut ? room.checkOut : 'Check Out'}
              </td>
              <td className='px-4 py-4 text-neutral-700 text-center'>${room.pricePerNight}</td>
              <td className='px-4 py-4 text-neutral-700 text-center grid place-items-center'>
                <EditIcon className='text-violet-500' size='24' />
              </td>
            </tr>
          ))}
        </table>
        <div></div>
      </section>
    </div>
  );
};

export default RoomsPage;
