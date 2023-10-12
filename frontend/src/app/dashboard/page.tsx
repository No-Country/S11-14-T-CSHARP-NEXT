import React from 'react';
import { FaBed } from 'react-icons/fa6';
import { TfiBookmarkAlt } from 'react-icons/tfi';
import { BsFillPersonFill, BsQuestionCircle } from 'react-icons/bs';
import { AiOutlineCheckCircle, AiOutlineCheckSquare } from 'react-icons/ai';
import { BiBlock, BiSolidMessageAltDetail } from 'react-icons/bi';

interface DashboardProps {}

const Dashboard: React.FC<DashboardProps> = () => {
  const dashboardInfo = [
    {
      icon: <FaBed className='w-[50px] h-[50px] text-gray-wiz' />,
      numero: '220',
      titulo: 'Total Habitaciones',
    },
    {
      icon: <TfiBookmarkAlt className='w-[50px] h-[50px] text-gray-wiz' />,
      numero: '52',
      titulo: 'Reservas',
    },
    {
      icon: <BsFillPersonFill className='w-[50px] h-[50px] text-gray-wiz' />,
      numero: '32',
      titulo: 'Staff',
    },
    {
      icon: <BsQuestionCircle className='w-[50px] h-[50px] text-gray-wiz' />,
      numero: '5',
      titulo: 'Incidentes/Quejas',
    },
    {
      icon: <AiOutlineCheckCircle className='w-[50px] h-[50px] text-[#22C008]' />,
      numero: '130',
      titulo: 'Habitaciones Disponibles',
    },
    {
      icon: <BiBlock className='w-[50px] h-[50px] text-[#F10A0A]' />,
      numero: '72',
      titulo: 'Habitaciones Ocupadas',
    },
    {
      icon: <AiOutlineCheckSquare className='w-[50px] h-[50px] text-gray-wiz' />,
      numero: '42',
      titulo: 'CheckIn Pendientes',
    },
    {
      icon: <BiSolidMessageAltDetail className='w-[50px] h-[50px] text-gray-wiz' />,
      numero: '5',
      titulo: 'Mensajes Nuevos',
    },
  ];
  return (
    <div className='grid grid-cols-4 grid-rows-2 font-Roboto border border-[#D9D9D9] bg-white rounded-lg'>
      {dashboardInfo.map((item, index) => (
        <div className='flex flex-col justify-center items-center py-14 border border-[#D9D9D9]' key={index}>
          <div className='mb-[10px]'>{item.icon}</div>
          <h2 className='text-[26px] text-black mb-[10px]'>{item.numero}</h2>
          <h3 className='text-lg text-black'>{item.titulo}</h3>
        </div>
      ))}
    </div>
  );
};

export default Dashboard;
