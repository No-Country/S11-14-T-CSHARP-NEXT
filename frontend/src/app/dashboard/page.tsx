import React from 'react';
import { NextPage } from 'next';
import { DASHBOARD_INFO } from '@utils/constants';
import DashboardCard from '@components/molecules/DashboardCard';

const Dashboard: NextPage = () => {
  return (
    <div className='px-[50px]'>
      <div className='grid grid-cols-4 grid-rows-2 font-roboto border border-[#D9D9D9] bg-white rounded-lg mt-[52px]'>
        {DASHBOARD_INFO.map((item, index) => (
          <div
            className='flex flex-col justify-center items-center py-14 border border-[#D9D9D9]'
            key={index}
          >
            <DashboardCard
              icon={item.icon}
              number={item.number}
              title={item.title}
              className={item.className}
            />
          </div>
        ))}
      </div>
    </div>
  );
};

export default Dashboard;
