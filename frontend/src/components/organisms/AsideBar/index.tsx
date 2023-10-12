import TitleLogo from '@components/atoms/TitleLogo';
import AsideBarItem from '@components/molecules/AsideBarItem';
import { MENU_ROUTES } from '@utils/constants';

const AsideBar: React.FC = () => {
  return (
    <div className='bg-gray-wiz-2 w-[20rem] h-screen flex flex-col items-center py-20'>
      <TitleLogo />

      <div className='mt-20 w-52'>
        {MENU_ROUTES.map(
          (route, index) =>
            route && <AsideBarItem key={index} itemName={route?.name} itemIcon={route?.icon} />,
        )}
      </div>
    </div>
  );
};

export default AsideBar;
